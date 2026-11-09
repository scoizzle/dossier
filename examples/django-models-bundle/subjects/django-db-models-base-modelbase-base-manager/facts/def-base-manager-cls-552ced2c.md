# Fact 552ced2c

Store id: 1ad086f8-92fc-49f9-98e9-dce73e675ab6

## Text

```text
def _base_manager(cls)
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
- posted_at: `2026-11-09T23:31:53.7275140+00:00`

## Data

```json
{
  "end_line": 455,
  "entity_kind": "method",
  "parent": "ModelBase",
  "start_line": 453,
  "symbol": "ModelBase._base_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":453,"selector":"L453-L455","symbol":"ModelBase._base_manager"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelBase._base_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 455,
    "entity_kind": "method",
    "parent": "ModelBase",
    "start_line": 453,
    "symbol": "ModelBase._base_manager"
  },
  "id": "1ad086f8-92fc-49f9-98e9-dce73e675ab6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7275140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 453,
        "selector": "L453-L455",
        "symbol": "ModelBase._base_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "8a981570-a076-44d8-afaf-a9e2986858a8",
  "subject_name": "django/db/models/base::ModelBase._base_manager",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _base_manager(cls)"
}
```
