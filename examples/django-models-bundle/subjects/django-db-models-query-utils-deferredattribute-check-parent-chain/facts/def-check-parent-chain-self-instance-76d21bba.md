# Fact 76d21bba

Store id: b09fa799-1d01-4ba2-9f3a-0eda6ca07731

## Text

```text
def _check_parent_chain(self, instance)
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
- posted_at: `2026-11-09T23:32:05.1162870+00:00`

## Data

```json
{
  "end_line": 299,
  "entity_kind": "method",
  "parent": "DeferredAttribute",
  "start_line": 289,
  "symbol": "DeferredAttribute._check_parent_chain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":289,"selector":"L289-L299","symbol":"DeferredAttribute._check_parent_chain"}`

## Items

```json
[
  {
    "text": "Check if the field value can be fetched from a parent field already loaded in the instance. This can be done if the to-be fetched field is a primary key field.",
    "locator": {
      "line": 290
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::DeferredAttribute._check_parent_chain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 299,
    "entity_kind": "method",
    "parent": "DeferredAttribute",
    "start_line": 289,
    "symbol": "DeferredAttribute._check_parent_chain"
  },
  "id": "b09fa799-1d01-4ba2-9f3a-0eda6ca07731",
  "items": [
    {
      "locator": {
        "line": 290
      },
      "text": "Check if the field value can be fetched from a parent field already loaded in the instance. This can be done if the to-be fetched field is a primary key field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1162870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 289,
        "selector": "L289-L299",
        "symbol": "DeferredAttribute._check_parent_chain"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "829d976c-d536-40c2-a521-918d34d38cb1",
  "subject_name": "django/db/models/query_utils::DeferredAttribute._check_parent_chain",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_parent_chain(self, instance)"
}
```
