# Fact bc7381a1

Store id: b804bf63-2de8-463c-a588-042d97d03211

## Text

```text
def get_child_with_renamed_prefix(prefix, replacement, child)
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
- posted_at: `2026-11-09T23:44:58.5039710+00:00`

## Data

```json
{
  "end_line": 138,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 105,
  "symbol": "get_child_with_renamed_prefix"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":105,"selector":"L105-L138","symbol":"get_child_with_renamed_prefix"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::get_child_with_renamed_prefix](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 138,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 105,
    "symbol": "get_child_with_renamed_prefix"
  },
  "id": "b804bf63-2de8-463c-a588-042d97d03211",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5039710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 105,
        "selector": "L105-L138",
        "symbol": "get_child_with_renamed_prefix"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4c269dcd-28b5-4922-a433-26e8b41c9389",
  "subject_name": "django/db/models/sql/query::get_child_with_renamed_prefix",
  "tags": [
    "entity:function"
  ],
  "text": "def get_child_with_renamed_prefix(prefix, replacement, child)"
}
```
