# Fact 226d1c28

Store id: f6407cf6-6d07-42e6-a980-1f1321fdead5

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
- posted_at: `2026-11-09T23:31:55.0913410+00:00`

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
  "id": "f6407cf6-6d07-42e6-a980-1f1321fdead5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0913410+00:00"
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
  "subject_id": "005f9048-056e-4164-9d30-ad2bd8ee3506",
  "subject_name": "django/db/models/deletion::get_candidate_relations_to_delete",
  "tags": [
    "entity:function"
  ],
  "text": "def get_candidate_relations_to_delete(opts)"
}
```
