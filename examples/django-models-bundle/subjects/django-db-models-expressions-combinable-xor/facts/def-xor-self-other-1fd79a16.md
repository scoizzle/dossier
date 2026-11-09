# Fact 1fd79a16

Store id: 4296ed58-e427-4789-b56a-228bb210a6a9

## Text

```text
def __xor__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2490440+00:00`

## Data

```json
{
  "end_line": 118,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 113,
  "symbol": "Combinable.__xor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":113,"selector":"L113-L118","symbol":"Combinable.__xor__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__xor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 118,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 113,
    "symbol": "Combinable.__xor__"
  },
  "id": "4296ed58-e427-4789-b56a-228bb210a6a9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2490440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 113,
        "selector": "L113-L118",
        "symbol": "Combinable.__xor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "67f7b65e-a2ef-4611-ab68-890201eaca24",
  "subject_name": "django/db/models/expressions::Combinable.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```
