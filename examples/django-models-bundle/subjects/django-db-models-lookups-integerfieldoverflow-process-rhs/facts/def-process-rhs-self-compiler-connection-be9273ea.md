# Fact be9273ea

Store id: e55febed-d98e-41b2-829f-ad7eb8e324a1

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:54.9772630+00:00`

## Data

```json
{
  "end_line": 460,
  "entity_kind": "method",
  "parent": "IntegerFieldOverflow",
  "start_line": 449,
  "symbol": "IntegerFieldOverflow.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":449,"selector":"L449-L460","symbol":"IntegerFieldOverflow.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldOverflow.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 460,
    "entity_kind": "method",
    "parent": "IntegerFieldOverflow",
    "start_line": 449,
    "symbol": "IntegerFieldOverflow.process_rhs"
  },
  "id": "e55febed-d98e-41b2-829f-ad7eb8e324a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9772630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 449,
        "selector": "L449-L460",
        "symbol": "IntegerFieldOverflow.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "eac8f17b-6316-4d96-adab-5261460190ca",
  "subject_name": "django/db/models/lookups::IntegerFieldOverflow.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
