# Fact 1b99462a

Store id: 77c3dfac-686e-4c50-ae29-a05c69b4e993

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
- posted_at: `2026-11-09T23:32:03.2630100+00:00`

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
  "id": "77c3dfac-686e-4c50-ae29-a05c69b4e993",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2630100+00:00"
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
  "subject_id": "c9298c1e-85e4-42cb-bccc-e7830af141c5",
  "subject_name": "django/db/models/lookups::IExact.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, qn, connection)"
}
```
