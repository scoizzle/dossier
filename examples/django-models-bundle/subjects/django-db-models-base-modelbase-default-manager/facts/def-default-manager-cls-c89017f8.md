# Fact c89017f8

Store id: 63c679c9-9d44-4180-bb61-9834e85a24c5

## Text

```text
def _default_manager(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.3275380+00:00`

## Data

```json
{
  "end_line": 459,
  "entity_kind": "method",
  "parent": "ModelBase",
  "start_line": 457,
  "symbol": "ModelBase._default_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":457,"selector":"L457-L459","symbol":"ModelBase._default_manager"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelBase._default_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 459,
    "entity_kind": "method",
    "parent": "ModelBase",
    "start_line": 457,
    "symbol": "ModelBase._default_manager"
  },
  "id": "63c679c9-9d44-4180-bb61-9834e85a24c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3275380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 457,
        "selector": "L457-L459",
        "symbol": "ModelBase._default_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "e3e7d14a-789b-401d-bff3-759fb2505ae3",
  "subject_name": "django/db/models/base::ModelBase._default_manager",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _default_manager(cls)"
}
```
