# Fact 210cdab6

Store id: fce39897-52a3-4b1b-8c99-d4712cc2de51

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
- posted_at: `2026-11-09T23:31:53.7654660+00:00`

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
  "id": "fce39897-52a3-4b1b-8c99-d4712cc2de51",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7654660+00:00"
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
  "subject_id": "9e811642-0105-455d-a45c-092beaf17752",
  "subject_name": "django/db/models/base::Model._check_model_name_db_lookup_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_model_name_db_lookup_clashes(cls)"
}
```
