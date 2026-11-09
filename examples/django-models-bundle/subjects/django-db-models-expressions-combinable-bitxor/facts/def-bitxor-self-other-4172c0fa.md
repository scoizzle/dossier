# Fact 4172c0fa

Store id: 3670c576-eed1-43fb-92dc-218ca4ced7f1

## Text

```text
def bitxor(self, other)
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
- posted_at: `2026-11-09T23:44:49.2497460+00:00`

## Data

```json
{
  "end_line": 121,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 120,
  "symbol": "Combinable.bitxor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":120,"selector":"L120-L121","symbol":"Combinable.bitxor"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.bitxor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 121,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 120,
    "symbol": "Combinable.bitxor"
  },
  "id": "3670c576-eed1-43fb-92dc-218ca4ced7f1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2497460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 120,
        "selector": "L120-L121",
        "symbol": "Combinable.bitxor"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "894b9f33-86a8-4ed8-a002-e5b987bddff6",
  "subject_name": "django/db/models/expressions::Combinable.bitxor",
  "tags": [
    "entity:method"
  ],
  "text": "def bitxor(self, other)"
}
```
