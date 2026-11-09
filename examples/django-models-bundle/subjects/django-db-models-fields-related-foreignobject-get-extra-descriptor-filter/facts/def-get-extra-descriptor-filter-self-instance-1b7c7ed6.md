# Fact 1b7c7ed6

Store id: a315cb59-b60e-426e-a1ff-719cbbdc839a

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
- posted_at: `2026-11-09T23:31:58.7102510+00:00`

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
  "id": "a315cb59-b60e-426e-a1ff-719cbbdc839a",
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
    "posted_at": "2026-11-09T23:31:58.7102510+00:00"
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
  "subject_id": "8089198b-1239-4879-8cea-92ef8ce8d443",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_extra_descriptor_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def get_extra_descriptor_filter(self, instance)"
}
```
