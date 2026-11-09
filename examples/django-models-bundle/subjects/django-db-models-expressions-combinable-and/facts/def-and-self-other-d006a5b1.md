# Fact d006a5b1

Store id: 33794f87-1e48-4b57-b1fc-37c780ea4281

## Text

```text
def __and__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7315030+00:00`

## Data

```json
{
  "end_line": 102,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 97,
  "symbol": "Combinable.__and__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"selector":"L97-L102","symbol":"Combinable.__and__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__and__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 102,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 97,
    "symbol": "Combinable.__and__"
  },
  "id": "33794f87-1e48-4b57-b1fc-37c780ea4281",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7315030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 97,
        "selector": "L97-L102",
        "symbol": "Combinable.__and__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6840a1d5-8710-48f3-820d-7eec188a18d7",
  "subject_name": "django/db/models/expressions::Combinable.__and__",
  "tags": [
    "entity:method"
  ],
  "text": "def __and__(self, other)"
}
```
