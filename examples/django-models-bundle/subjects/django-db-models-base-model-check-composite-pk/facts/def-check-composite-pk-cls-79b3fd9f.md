# Fact 79b3fd9f

Store id: 3af00649-2557-4ecd-aced-f9436ddf2915

## Text

```text
def _check_composite_pk(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.3545870+00:00`

## Data

```json
{
  "end_line": 1870,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1813,
  "symbol": "Model._check_composite_pk"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1813,"selector":"L1813-L1870","symbol":"Model._check_composite_pk"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_composite_pk](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1870,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1813,
    "symbol": "Model._check_composite_pk"
  },
  "id": "3af00649-2557-4ecd-aced-f9436ddf2915",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3545870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1813,
        "selector": "L1813-L1870",
        "symbol": "Model._check_composite_pk"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "be38d477-1ad7-46c2-bb99-6ada1b0d3b8e",
  "subject_name": "django/db/models/base::Model._check_composite_pk",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_composite_pk(cls)"
}
```
