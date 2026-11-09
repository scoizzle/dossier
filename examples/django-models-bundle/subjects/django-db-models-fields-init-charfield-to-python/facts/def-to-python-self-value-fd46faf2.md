# Fact fd46faf2

Store id: 795b561f-6497-4365-8d44-a7ae77726a8a

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
- posted_at: `2026-11-09T22:39:42.3847590+00:00`

## Data

```json
{
  "end_line": 1336,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1333,
  "symbol": "CharField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1333,"selector":"L1333-L1336","symbol":"CharField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1336,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1333,
    "symbol": "CharField.to_python"
  },
  "id": "795b561f-6497-4365-8d44-a7ae77726a8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3847590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1333,
        "selector": "L1333-L1336",
        "symbol": "CharField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "85fcf7a8-650a-4197-a120-6dc706085c7a",
  "subject_name": "django/db/models/fields/__init__::CharField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
