# Fact 9a94f60d

Store id: 8bfc6762-e38e-45a2-956f-a620178beae3

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
- posted_at: `2026-11-09T23:44:52.7462630+00:00`

## Data

```json
{
  "end_line": 127,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 107,
  "symbol": "TupleLookupMixin.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L127","symbol":"TupleLookupMixin.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 127,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 107,
    "symbol": "TupleLookupMixin.process_rhs"
  },
  "id": "8bfc6762-e38e-45a2-956f-a620178beae3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7462630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L127",
        "symbol": "TupleLookupMixin.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e58871c9-1451-4a26-955a-33d8c385da30",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
