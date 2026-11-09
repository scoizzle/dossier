# Fact dc301a2d

Store id: bda53771-fe35-4b09-8567-2a6ce98ce350

## Text

```text
def get_normalized_value(value, lhs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:59.9612140+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "function",
  "parent": "related_lookups",
  "start_line": 15,
  "symbol": "get_normalized_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":15,"selector":"L15-L39","symbol":"get_normalized_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::get_normalized_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "function",
    "parent": "related_lookups",
    "start_line": 15,
    "symbol": "get_normalized_value"
  },
  "id": "bda53771-fe35-4b09-8567-2a6ce98ce350",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.9612140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 15,
        "selector": "L15-L39",
        "symbol": "get_normalized_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "9ed5cc3b-3c3e-4c7c-ba18-0de299538b1d",
  "subject_name": "django/db/models/fields/related_lookups::get_normalized_value",
  "tags": [
    "entity:function"
  ],
  "text": "def get_normalized_value(value, lhs)"
}
```
