# Fact 1b99462a

Store id: 2de043ce-50bb-4111-86da-67cc12847b6f

## Text

```text
def process_rhs(self, qn, connection)
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
- posted_at: `2026-11-09T22:39:48.1116820+00:00`

## Data

```json
{
  "end_line": 422,
  "entity_kind": "method",
  "parent": "IExact",
  "start_line": 418,
  "symbol": "IExact.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":418,"selector":"L418-L422","symbol":"IExact.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IExact.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 422,
    "entity_kind": "method",
    "parent": "IExact",
    "start_line": 418,
    "symbol": "IExact.process_rhs"
  },
  "id": "2de043ce-50bb-4111-86da-67cc12847b6f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1116820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 418,
        "selector": "L418-L422",
        "symbol": "IExact.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "ad66efcf-d3c2-4544-a210-562c0e5587c5",
  "subject_name": "django/db/models/lookups::IExact.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, qn, connection)"
}
```
