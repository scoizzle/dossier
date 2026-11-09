# Fact 210cdab6

Store id: d268b1ef-934b-4ebb-8ef5-5ea53dce70fe

## Text

```text
def _check_model_name_db_lookup_clashes(cls)
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
- posted_at: `2026-11-09T22:39:40.3604970+00:00`

## Data

```json
{
  "end_line": 2128,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2106,
  "symbol": "Model._check_model_name_db_lookup_clashes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2106,"selector":"L2106-L2128","symbol":"Model._check_model_name_db_lookup_clashes"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_model_name_db_lookup_clashes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2128,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2106,
    "symbol": "Model._check_model_name_db_lookup_clashes"
  },
  "id": "d268b1ef-934b-4ebb-8ef5-5ea53dce70fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3604970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2106,
        "selector": "L2106-L2128",
        "symbol": "Model._check_model_name_db_lookup_clashes"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "4af035ee-fdc7-4039-a115-dd35dceba2f6",
  "subject_name": "django/db/models/base::Model._check_model_name_db_lookup_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_model_name_db_lookup_clashes(cls)"
}
```
