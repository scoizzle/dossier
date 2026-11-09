# Fact 76d21bba

Store id: 1e29e04b-b7ce-47ba-aa46-87e82f971915

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
- posted_at: `2026-11-09T23:44:56.6183520+00:00`

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
  "id": "1e29e04b-b7ce-47ba-aa46-87e82f971915",
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
    "posted_at": "2026-11-09T23:44:56.6183520+00:00"
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
  "subject_id": "93f9e4db-48ef-4a72-8daf-64e6bd2d0188",
  "subject_name": "django/db/models/query_utils::DeferredAttribute._check_parent_chain",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_parent_chain(self, instance)"
}
```
