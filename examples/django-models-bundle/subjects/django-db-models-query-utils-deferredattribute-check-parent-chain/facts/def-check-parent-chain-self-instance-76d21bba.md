# Fact 76d21bba

Store id: 2606d1c1-f81d-4f05-9ce0-39a8bddd8d51

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
- posted_at: `2026-11-09T22:39:50.1185190+00:00`

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
  "id": "2606d1c1-f81d-4f05-9ce0-39a8bddd8d51",
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
    "posted_at": "2026-11-09T22:39:50.1185190+00:00"
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
  "subject_id": "def5c9b4-a757-4ab0-b37a-c1d840a7e1bc",
  "subject_name": "django/db/models/query_utils::DeferredAttribute._check_parent_chain",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_parent_chain(self, instance)"
}
```
