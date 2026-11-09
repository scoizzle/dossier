# Fact 3f4fa109

Store id: 74fcf248-15fe-48ce-99a7-90aaf39e6916

## Text

```text
def bitleftshift(self, other)
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
- posted_at: `2026-11-09T22:39:41.4783270+00:00`

## Data

```json
{
  "end_line": 108,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 107,
  "symbol": "Combinable.bitleftshift"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L108","symbol":"Combinable.bitleftshift"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.bitleftshift](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 108,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 107,
    "symbol": "Combinable.bitleftshift"
  },
  "id": "74fcf248-15fe-48ce-99a7-90aaf39e6916",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4783270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L108",
        "symbol": "Combinable.bitleftshift"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "16cf6996-b71d-4b60-86ac-80de659341db",
  "subject_name": "django/db/models/expressions::Combinable.bitleftshift",
  "tags": [
    "entity:method"
  ],
  "text": "def bitleftshift(self, other)"
}
```
