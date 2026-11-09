# Fact ba3957d4

Store id: b3f950e5-35ec-4b84-9c33-5ebf3bea7a29

## Text

```text
def _get_set_deprecation_msg_params(self)
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
- posted_at: `2026-11-09T22:39:44.8478480+00:00`

## Data

```json
{
  "end_line": 1072,
  "entity_kind": "method",
  "parent": "ManyToManyDescriptor",
  "start_line": 1067,
  "symbol": "ManyToManyDescriptor._get_set_deprecation_msg_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1067,"selector":"L1067-L1072","symbol":"ManyToManyDescriptor._get_set_deprecation_msg_params"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ManyToManyDescriptor._get_set_deprecation_msg_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1072,
    "entity_kind": "method",
    "parent": "ManyToManyDescriptor",
    "start_line": 1067,
    "symbol": "ManyToManyDescriptor._get_set_deprecation_msg_params"
  },
  "id": "b3f950e5-35ec-4b84-9c33-5ebf3bea7a29",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8478480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1067,
        "selector": "L1067-L1072",
        "symbol": "ManyToManyDescriptor._get_set_deprecation_msg_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "fa646303-4c2b-460b-b3f4-c84175838e09",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor._get_set_deprecation_msg_params",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_set_deprecation_msg_params(self)"
}
```
