# Fact 1fd79a16

Store id: 7bbdcfcb-8bdb-4756-b7b7-1d61664d61d9

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
- posted_at: `2026-11-09T22:39:41.4799370+00:00`

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
  "id": "7bbdcfcb-8bdb-4756-b7b7-1d61664d61d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4799370+00:00"
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
  "subject_id": "172f56e0-d42c-491c-b1ee-49d0d5a2fc87",
  "subject_name": "django/db/models/expressions::Combinable.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```
