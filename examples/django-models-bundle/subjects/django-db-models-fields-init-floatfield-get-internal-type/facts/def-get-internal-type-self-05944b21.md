# Fact 05944b21

Store id: 1e721edf-e347-45aa-ba18-31626cb8929b

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T22:39:42.5219940+00:00`

## Data

```json
{
  "end_line": 2118,
  "entity_kind": "method",
  "parent": "FloatField",
  "start_line": 2117,
  "symbol": "FloatField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2117,"selector":"L2117-L2118","symbol":"FloatField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2118,
    "entity_kind": "method",
    "parent": "FloatField",
    "start_line": 2117,
    "symbol": "FloatField.get_internal_type"
  },
  "id": "1e721edf-e347-45aa-ba18-31626cb8929b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5219940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2117,
        "selector": "L2117-L2118",
        "symbol": "FloatField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "af5fa3c0-7da0-4534-bd86-a224e7de8c50",
  "subject_name": "django/db/models/fields/__init__::FloatField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
