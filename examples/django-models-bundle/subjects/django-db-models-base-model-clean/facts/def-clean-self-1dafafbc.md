# Fact 1dafafbc

Store id: 3960c23b-bbad-4e8d-a37e-3c04f94b58ea

## Text

```text
def clean(self)
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
- posted_at: `2026-11-09T23:31:53.7539880+00:00`

## Data

```json
{
  "end_line": 1458,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1450,
  "symbol": "Model.clean"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1450,"selector":"L1450-L1458","symbol":"Model.clean"}`

## Items

```json
[
  {
    "text": "Hook for doing any extra model-wide validation after clean() has been called on every field by self.clean_fields. Any ValidationError raised by this method will not be associated with a particular field; it will have a special-case association with the field defined by NON_FIELD_ERRORS.",
    "locator": {
      "line": 1451
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.clean](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1458,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1450,
    "symbol": "Model.clean"
  },
  "id": "3960c23b-bbad-4e8d-a37e-3c04f94b58ea",
  "items": [
    {
      "locator": {
        "line": 1451
      },
      "text": "Hook for doing any extra model-wide validation after clean() has been called on every field by self.clean_fields. Any ValidationError raised by this method will not be associated with a particular field; it will have a special-case association with the field defined by NON_FIELD_ERRORS."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7539880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1450,
        "selector": "L1450-L1458",
        "symbol": "Model.clean"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "b57b4a32-ffbe-4fe3-be15-cff2b7023e03",
  "subject_name": "django/db/models/base::Model.clean",
  "tags": [
    "entity:method"
  ],
  "text": "def clean(self)"
}
```
