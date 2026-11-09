# Fact bc7381a1

Store id: 16a493e3-2816-46e9-abf8-a8f1e40aeb3e

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
- posted_at: `2026-11-09T23:32:06.6732260+00:00`

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
  "id": "16a493e3-2816-46e9-abf8-a8f1e40aeb3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.6732260+00:00"
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
  "subject_id": "844225ec-6ae1-44c1-a507-3e47b204b4d5",
  "subject_name": "django/db/models/sql/query::get_child_with_renamed_prefix",
  "tags": [
    "entity:function"
  ],
  "text": "def get_child_with_renamed_prefix(prefix, replacement, child)"
}
```
