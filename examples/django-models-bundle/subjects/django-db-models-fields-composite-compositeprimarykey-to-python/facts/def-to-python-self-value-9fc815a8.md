# Fact 9fc815a8

Store id: d8728389-0421-463c-acbd-2cb46f5cf5e3

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
- posted_at: `2026-11-09T22:39:43.0208140+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 148,
  "symbol": "CompositePrimaryKey.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":148,"selector":"L148-L156","symbol":"CompositePrimaryKey.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 148,
    "symbol": "CompositePrimaryKey.to_python"
  },
  "id": "d8728389-0421-463c-acbd-2cb46f5cf5e3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0208140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 148,
        "selector": "L148-L156",
        "symbol": "CompositePrimaryKey.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "345f28e2-c93f-4fc1-b9ae-677ecba2e3c4",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
