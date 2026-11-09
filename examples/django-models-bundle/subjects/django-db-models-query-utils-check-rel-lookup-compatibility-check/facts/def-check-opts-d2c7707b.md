# Fact d2c7707b

Store id: c40cee61-b879-468e-83cb-a1d451d21772

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
- posted_at: `2026-11-09T22:39:50.1800690+00:00`

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
  "id": "c40cee61-b879-468e-83cb-a1d451d21772",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1800690+00:00"
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
  "subject_id": "6a34651f-ec1a-47f9-9ab9-01ba0a3c7caf",
  "subject_name": "django/db/models/query_utils::check_rel_lookup_compatibility.check",
  "tags": [
    "entity:function"
  ],
  "text": "def check(opts)"
}
```
