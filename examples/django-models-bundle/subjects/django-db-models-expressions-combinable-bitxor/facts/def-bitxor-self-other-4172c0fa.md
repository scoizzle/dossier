# Fact 4172c0fa

Store id: cf380deb-222f-4b7c-bbb5-75f7ac70363f

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
- posted_at: `2026-11-09T23:31:55.7378450+00:00`

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
  "id": "cf380deb-222f-4b7c-bbb5-75f7ac70363f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7378450+00:00"
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
  "subject_id": "cff75b80-e51f-4e3a-83dd-849f49c8faf9",
  "subject_name": "django/db/models/expressions::Combinable.bitxor",
  "tags": [
    "entity:method"
  ],
  "text": "def bitxor(self, other)"
}
```
