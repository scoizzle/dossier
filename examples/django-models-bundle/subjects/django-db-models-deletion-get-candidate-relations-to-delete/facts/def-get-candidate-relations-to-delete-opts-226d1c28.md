# Fact 226d1c28

Store id: 6edd110a-ea56-413d-b422-79fb53190f4f

## Text

```text
def get_candidate_relations_to_delete(opts)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.0367450+00:00`

## Data

```json
{
  "end_line": 114,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 106,
  "symbol": "get_candidate_relations_to_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":106,"selector":"L106-L114","symbol":"get_candidate_relations_to_delete"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::get_candidate_relations_to_delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 114,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 106,
    "symbol": "get_candidate_relations_to_delete"
  },
  "id": "6edd110a-ea56-413d-b422-79fb53190f4f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0367450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 106,
        "selector": "L106-L114",
        "symbol": "get_candidate_relations_to_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "e016def7-b47a-4a12-b4c7-65d4a737e282",
  "subject_name": "django/db/models/deletion::get_candidate_relations_to_delete",
  "tags": [
    "entity:function"
  ],
  "text": "def get_candidate_relations_to_delete(opts)"
}
```
