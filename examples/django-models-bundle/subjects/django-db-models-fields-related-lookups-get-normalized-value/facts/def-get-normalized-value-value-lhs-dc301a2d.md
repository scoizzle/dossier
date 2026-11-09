# Fact dc301a2d

Store id: a8b2b4c2-95fc-4aa1-aade-3da1850deeb6

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
- posted_at: `2026-11-09T22:39:45.0858640+00:00`

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
  "id": "a8b2b4c2-95fc-4aa1-aade-3da1850deeb6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.0858640+00:00"
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
  "subject_id": "6b5c5003-fb84-4fd1-860f-dd2f5f16b5a4",
  "subject_name": "django/db/models/fields/related_lookups::get_normalized_value",
  "tags": [
    "entity:function"
  ],
  "text": "def get_normalized_value(value, lhs)"
}
```
