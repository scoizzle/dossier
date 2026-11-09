# Fact 2430d5e2

Store id: 4355b274-40a7-4897-b6a7-80c2f79f810a

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
- posted_at: `2026-11-09T23:44:51.8959970+00:00`

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
  "id": "4355b274-40a7-4897-b6a7-80c2f79f810a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8959970+00:00"
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
  "subject_id": "78fd4598-1e6c-4235-83bc-fc752e9ab66e",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor._get_set_deprecation_msg_params",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_set_deprecation_msg_params(self)"
}
```
