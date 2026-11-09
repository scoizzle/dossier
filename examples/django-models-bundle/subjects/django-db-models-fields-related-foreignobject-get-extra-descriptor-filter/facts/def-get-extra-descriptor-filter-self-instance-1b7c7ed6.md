# Fact 1b7c7ed6

Store id: aef04ac4-cec9-4204-be29-04b38f8e5b67

## Text

```text
def get_extra_descriptor_filter(self, instance)
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
- posted_at: `2026-11-09T23:44:51.5454440+00:00`

## Data

```json
{
  "end_line": 875,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 862,
  "symbol": "ForeignObject.get_extra_descriptor_filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":862,"selector":"L862-L875","symbol":"ForeignObject.get_extra_descriptor_filter"}`

## Items

```json
[
  {
    "text": "Return an extra filter condition for related object fetching when user does 'instance.fieldname', that is the extra filter is used in the descriptor of the field.",
    "locator": {
      "line": 863
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_extra_descriptor_filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 875,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 862,
    "symbol": "ForeignObject.get_extra_descriptor_filter"
  },
  "id": "aef04ac4-cec9-4204-be29-04b38f8e5b67",
  "items": [
    {
      "locator": {
        "line": 863
      },
      "text": "Return an extra filter condition for related object fetching when user does 'instance.fieldname', that is the extra filter is used in the descriptor of the field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5454440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 862,
        "selector": "L862-L875",
        "symbol": "ForeignObject.get_extra_descriptor_filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "bf5056cf-45f5-48d9-bba3-9e15b3c87bd3",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_extra_descriptor_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def get_extra_descriptor_filter(self, instance)"
}
```
