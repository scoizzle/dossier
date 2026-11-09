# Fact f1a12679

Store id: d7f4b683-c435-4926-afe4-1604a29a213a

## Text

```text
def to_python(self, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.3073700+00:00`

## Data

```json
{
  "end_line": 2863,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2852,
  "symbol": "UUIDField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2852,"selector":"L2852-L2863","symbol":"UUIDField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2863,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2852,
    "symbol": "UUIDField.to_python"
  },
  "id": "d7f4b683-c435-4926-afe4-1604a29a213a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3073700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2852,
        "selector": "L2852-L2863",
        "symbol": "UUIDField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c7d5a4c9-56a9-4f53-8cfc-6993c221fe37",
  "subject_name": "django/db/models/fields/__init__::UUIDField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
