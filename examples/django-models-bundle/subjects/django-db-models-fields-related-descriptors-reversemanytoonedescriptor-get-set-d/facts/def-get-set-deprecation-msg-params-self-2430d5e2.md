# Fact 2430d5e2

Store id: 48aed379-b729-49f4-902b-cb7939c6c343

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
- posted_at: `2026-11-09T22:39:44.7796010+00:00`

## Data

```json
{
  "end_line": 705,
  "entity_kind": "method",
  "parent": "ReverseManyToOneDescriptor",
  "start_line": 701,
  "symbol": "ReverseManyToOneDescriptor._get_set_deprecation_msg_params"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":701,"selector":"L701-L705","symbol":"ReverseManyToOneDescriptor._get_set_deprecation_msg_params"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor._get_set_deprecation_msg_params](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 705,
    "entity_kind": "method",
    "parent": "ReverseManyToOneDescriptor",
    "start_line": 701,
    "symbol": "ReverseManyToOneDescriptor._get_set_deprecation_msg_params"
  },
  "id": "48aed379-b729-49f4-902b-cb7939c6c343",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7796010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 701,
        "selector": "L701-L705",
        "symbol": "ReverseManyToOneDescriptor._get_set_deprecation_msg_params"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "e4193129-f39d-4b16-a4c2-df34afea82a3",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor._get_set_deprecation_msg_params",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_set_deprecation_msg_params(self)"
}
```
