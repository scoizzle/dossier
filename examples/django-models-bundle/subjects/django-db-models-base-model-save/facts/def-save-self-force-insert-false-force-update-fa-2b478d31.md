# Fact 2b478d31

Store id: 5bf87160-451d-4785-b5ba-8e74c2f902ec

## Text

```text
def save( self, *, force_insert=False, force_update=False, using=None, update_fields=None, )
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
- posted_at: `2026-11-09T23:31:53.7400450+00:00`

## Data

```json
{
  "end_line": 909,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 841,
  "symbol": "Model.save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":841,"selector":"L841-L909","symbol":"Model.save"}`

## Items

```json
[
  {
    "text": "Save the current instance. Override this in a subclass if you want to control the saving process.",
    "locator": {
      "line": 849
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 909,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 841,
    "symbol": "Model.save"
  },
  "id": "5bf87160-451d-4785-b5ba-8e74c2f902ec",
  "items": [
    {
      "locator": {
        "line": 849
      },
      "text": "Save the current instance. Override this in a subclass if you want to control the saving process."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7400450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 841,
        "selector": "L841-L909",
        "symbol": "Model.save"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "9e4a1f6d-cb4f-4bad-84a7-cb09df9fb492",
  "subject_name": "django/db/models/base::Model.save",
  "tags": [
    "entity:method"
  ],
  "text": "def save( self, *, force_insert=False, force_update=False, using=None, update_fields=None, )"
}
```
