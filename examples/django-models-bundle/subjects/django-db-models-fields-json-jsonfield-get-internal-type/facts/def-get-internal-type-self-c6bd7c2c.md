# Fact c6bd7c2c

Store id: 8ea1157c-4c12-4ab7-b85b-aeae5f065af8

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
- posted_at: `2026-11-09T23:31:57.8448280+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 98,
  "symbol": "JSONField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":98,"selector":"L98-L99","symbol":"JSONField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 98,
    "symbol": "JSONField.get_internal_type"
  },
  "id": "8ea1157c-4c12-4ab7-b85b-aeae5f065af8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8448280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 98,
        "selector": "L98-L99",
        "symbol": "JSONField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "8983b5c9-83ba-41dc-bc3c-46c7ec468809",
  "subject_name": "django/db/models/fields/json::JSONField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
