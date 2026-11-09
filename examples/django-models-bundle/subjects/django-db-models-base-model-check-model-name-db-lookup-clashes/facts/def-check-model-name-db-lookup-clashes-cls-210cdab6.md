# Fact 210cdab6

Store id: a6ae73f2-43ac-42d6-9275-b5488aab6b31

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
- posted_at: `2026-11-09T23:44:48.5504450+00:00`

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
  "id": "a6ae73f2-43ac-42d6-9275-b5488aab6b31",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5504450+00:00"
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
  "subject_id": "f5927337-0ce6-4624-a519-c05ff8ed6942",
  "subject_name": "django/db/models/base::Model._check_model_name_db_lookup_clashes",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_model_name_db_lookup_clashes(cls)"
}
```
