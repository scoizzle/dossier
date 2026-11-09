# Fact dc301a2d

Store id: 9d5073f7-3cb1-479b-8309-d7a16eaa2017

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
- posted_at: `2026-11-09T23:44:52.2208100+00:00`

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
  "id": "9d5073f7-3cb1-479b-8309-d7a16eaa2017",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2208100+00:00"
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
  "subject_id": "c98947f9-3330-414e-800b-8691e959859d",
  "subject_name": "django/db/models/fields/related_lookups::get_normalized_value",
  "tags": [
    "entity:function"
  ],
  "text": "def get_normalized_value(value, lhs)"
}
```
