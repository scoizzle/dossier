# Fact 2b608022

Store id: 44e7f995-5fd9-4dec-bd99-4a7ecdeabc03

## Text

```text
def check_rel_lookup_compatibility(model, target_opts, field)
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
- posted_at: `2026-11-09T23:32:05.1945050+00:00`

## Data

```json
{
  "end_line": 517,
  "entity_kind": "function",
  "parent": "query_utils",
  "start_line": 491,
  "symbol": "check_rel_lookup_compatibility"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":491,"selector":"L491-L517","symbol":"check_rel_lookup_compatibility"}`

## Items

```json
[
  {
    "text": "Check that self.model is compatible with target_opts. Compatibility is OK if: 1) model and opts match (where proxy inheritance is removed) 2) model is parent of opts' model or the other way around",
    "locator": {
      "line": 492
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::check_rel_lookup_compatibility](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 517,
    "entity_kind": "function",
    "parent": "query_utils",
    "start_line": 491,
    "symbol": "check_rel_lookup_compatibility"
  },
  "id": "44e7f995-5fd9-4dec-bd99-4a7ecdeabc03",
  "items": [
    {
      "locator": {
        "line": 492
      },
      "text": "Check that self.model is compatible with target_opts. Compatibility is OK if: 1) model and opts match (where proxy inheritance is removed) 2) model is parent of opts' model or the other way around"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1945050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 491,
        "selector": "L491-L517",
        "symbol": "check_rel_lookup_compatibility"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "d645cd3b-7161-4e40-88f5-e42922a6947a",
  "subject_name": "django/db/models/query_utils::check_rel_lookup_compatibility",
  "tags": [
    "entity:function"
  ],
  "text": "def check_rel_lookup_compatibility(model, target_opts, field)"
}
```
