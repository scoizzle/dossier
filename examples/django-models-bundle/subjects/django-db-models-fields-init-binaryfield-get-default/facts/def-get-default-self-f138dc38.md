# Fact f138dc38

Store id: 910b0e07-c887-4393-bb54-f3c8200da96a

## Text

```text
def get_default(self)
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
- posted_at: `2026-11-09T22:39:42.6994420+00:00`

## Data

```json
{
  "end_line": 2792,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2786,
  "symbol": "BinaryField.get_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2786,"selector":"L2786-L2792","symbol":"BinaryField.get_default"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.get_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2792,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2786,
    "symbol": "BinaryField.get_default"
  },
  "id": "910b0e07-c887-4393-bb54-f3c8200da96a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6994420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2786,
        "selector": "L2786-L2792",
        "symbol": "BinaryField.get_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0b0f9ab7-1a6c-47bd-b59a-5ee7ea9f78ec",
  "subject_name": "django/db/models/fields/__init__::BinaryField.get_default",
  "tags": [
    "entity:method"
  ],
  "text": "def get_default(self)"
}
```
