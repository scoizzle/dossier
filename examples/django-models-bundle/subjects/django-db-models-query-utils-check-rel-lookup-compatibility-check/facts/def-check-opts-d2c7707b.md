# Fact d2c7707b

Store id: d98b04fd-c5fa-4085-b57a-ac7b98ffc69a

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
- posted_at: `2026-11-09T23:44:56.7320390+00:00`

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
  "id": "d98b04fd-c5fa-4085-b57a-ac7b98ffc69a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7320390+00:00"
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
  "subject_id": "ea8522e0-751c-4646-93b2-469d9a1b0573",
  "subject_name": "django/db/models/query_utils::check_rel_lookup_compatibility.check",
  "tags": [
    "entity:function"
  ],
  "text": "def check(opts)"
}
```
