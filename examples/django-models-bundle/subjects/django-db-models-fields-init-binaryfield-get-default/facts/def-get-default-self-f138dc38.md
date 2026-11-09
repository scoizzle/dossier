# Fact f138dc38

Store id: f7005545-6c2e-44de-95b9-4b37345288d2

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
- posted_at: `2026-11-09T23:31:56.8601360+00:00`

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
  "id": "f7005545-6c2e-44de-95b9-4b37345288d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8601360+00:00"
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
  "subject_id": "0c1b83a2-1402-4c7a-a9fb-9be61a86a2c6",
  "subject_name": "django/db/models/fields/__init__::BinaryField.get_default",
  "tags": [
    "entity:method"
  ],
  "text": "def get_default(self)"
}
```
