# Fact d2c7707b

Store id: 6cc3b225-c7c6-48a2-ace0-0b0ded60abed

## Text

```text
def check(opts)
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
- posted_at: `2026-11-09T23:32:05.1973880+00:00`

## Data

```json
{
  "end_line": 504,
  "entity_kind": "function",
  "parent": "check_rel_lookup_compatibility",
  "start_line": 499,
  "symbol": "check_rel_lookup_compatibility.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":499,"selector":"L499-L504","symbol":"check_rel_lookup_compatibility.check"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::check_rel_lookup_compatibility.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 504,
    "entity_kind": "function",
    "parent": "check_rel_lookup_compatibility",
    "start_line": 499,
    "symbol": "check_rel_lookup_compatibility.check"
  },
  "id": "6cc3b225-c7c6-48a2-ace0-0b0ded60abed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1973880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 499,
        "selector": "L499-L504",
        "symbol": "check_rel_lookup_compatibility.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "df8c9839-b0c4-4323-a4ef-eeb2f45516ab",
  "subject_name": "django/db/models/query_utils::check_rel_lookup_compatibility.check",
  "tags": [
    "entity:function"
  ],
  "text": "def check(opts)"
}
```
