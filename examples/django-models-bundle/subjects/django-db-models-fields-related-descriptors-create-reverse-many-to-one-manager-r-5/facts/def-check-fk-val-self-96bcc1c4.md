# Fact 96bcc1c4

Store id: 0a175844-1b95-4c05-8974-b8ce09dc7483

## Text

```text
def _check_fk_val(self)
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
- posted_at: `2026-11-09T23:31:59.2380230+00:00`

## Data

```json
{
  "end_line": 745,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 739,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager._check_fk_val"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":739,"selector":"L739-L745","symbol":"create_reverse_many_to_one_manager.RelatedManager._check_fk_val"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._check_fk_val](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 745,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 739,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager._check_fk_val"
  },
  "id": "0a175844-1b95-4c05-8974-b8ce09dc7483",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2380230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 739,
        "selector": "L739-L745",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager._check_fk_val"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "db2e2414-682f-4469-84c2-2d03a53436c6",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._check_fk_val",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fk_val(self)"
}
```
