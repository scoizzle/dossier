# Fact b0e025b6

Store id: 22d13638-7510-4e95-a33c-834bfdc9f71c

## Text

```text
def replace_expressions(self, replacements)
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
- posted_at: `2026-11-09T22:39:50.0855240+00:00`

## Data

```json
{
  "end_line": 154,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 117,
  "symbol": "Q.replace_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L154","symbol":"Q.replace_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.replace_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 154,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 117,
    "symbol": "Q.replace_expressions"
  },
  "id": "22d13638-7510-4e95-a33c-834bfdc9f71c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0855240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L154",
        "symbol": "Q.replace_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "64ffe7b8-4a65-475e-85ac-8d299999fe62",
  "subject_name": "django/db/models/query_utils::Q.replace_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def replace_expressions(self, replacements)"
}
```
