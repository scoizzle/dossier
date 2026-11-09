# Fact b95f9d78

Store id: e211ccd4-f732-4a51-b17f-69f8b29b6f18

## Text

```text
def _get_missing_target_ids( self, source_field_name, target_field_name, db, target_ids )
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
- posted_at: `2026-11-09T22:39:44.9393200+00:00`

## Data

```json
{
  "end_line": 1547,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1530,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_missing_target_ids"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1530,"selector":"L1530-L1547","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._get_missing_target_ids"}`

## Items

```json
[
  {
    "text": "Return the subset of ids of `objs` that aren't already assigned to this relationship.",
    "locator": {
      "line": 1533
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._get_missing_target_ids](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1547,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1530,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_missing_target_ids"
  },
  "id": "e211ccd4-f732-4a51-b17f-69f8b29b6f18",
  "items": [
    {
      "locator": {
        "line": 1533
      },
      "text": "Return the subset of ids of `objs` that aren't already assigned to this relationship."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9393200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1530,
        "selector": "L1530-L1547",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_missing_target_ids"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "fee86332-1b15-45fa-9475-31263e82e952",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._get_missing_target_ids",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_missing_target_ids( self, source_field_name, target_field_name, db, target_ids )"
}
```
