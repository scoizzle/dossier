# Fact ab54851a

Store id: 1d9a7388-35bf-46c0-a3f5-eff46b4d9983

## Text

```text
def save_base( self, raw=False, force_insert=False, force_update=False, using=None, update_fields=None, )
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
- posted_at: `2026-11-09T23:31:53.7419110+00:00`

## Data

```json
{
  "end_line": 1018,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 950,
  "symbol": "Model.save_base"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":950,"selector":"L950-L1018","symbol":"Model.save_base"}`

## Items

```json
[
  {
    "text": "Handle the parts of saving which should be done only once per save, yet need to be done in raw saves, too. This includes some sanity checks and signal sending.",
    "locator": {
      "line": 958
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.save_base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1018,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 950,
    "symbol": "Model.save_base"
  },
  "id": "1d9a7388-35bf-46c0-a3f5-eff46b4d9983",
  "items": [
    {
      "locator": {
        "line": 958
      },
      "text": "Handle the parts of saving which should be done only once per save, yet need to be done in raw saves, too. This includes some sanity checks and signal sending."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7419110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 950,
        "selector": "L950-L1018",
        "symbol": "Model.save_base"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "8e0b5c77-e343-4a2f-a1a8-89a58b7487b2",
  "subject_name": "django/db/models/base::Model.save_base",
  "tags": [
    "entity:method"
  ],
  "text": "def save_base( self, raw=False, force_insert=False, force_update=False, using=None, update_fields=None, )"
}
```
