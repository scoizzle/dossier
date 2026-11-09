# Fact 9a94f60d

Store id: 0cc95303-154f-4e65-bdd6-cb0bbb2a18da

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
- posted_at: `2026-11-09T22:39:45.5852230+00:00`

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
  "id": "0cc95303-154f-4e65-bdd6-cb0bbb2a18da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5852230+00:00"
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
  "subject_id": "1b801863-2d31-443f-9415-b0aae59028a7",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
