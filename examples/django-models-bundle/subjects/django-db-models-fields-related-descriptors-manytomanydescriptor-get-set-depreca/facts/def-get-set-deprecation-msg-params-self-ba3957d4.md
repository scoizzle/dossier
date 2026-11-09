# Fact ba3957d4

Store id: 547ca027-42a6-4aec-812c-52f1c9796e13

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
- posted_at: `2026-11-09T23:44:51.9567750+00:00`

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
  "id": "547ca027-42a6-4aec-812c-52f1c9796e13",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9567750+00:00"
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
  "subject_id": "254bd370-8639-4826-a934-5b5cdfc4b4e6",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor._get_set_deprecation_msg_params",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_set_deprecation_msg_params(self)"
}
```
