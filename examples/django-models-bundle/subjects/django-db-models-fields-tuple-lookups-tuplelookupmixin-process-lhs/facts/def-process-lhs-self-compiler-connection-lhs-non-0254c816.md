# Fact 0254c816

Store id: aa0b7165-1a48-4a34-8fae-bb5d3632e133

## Text

```text
def process_lhs(self, compiler, connection, lhs=None)
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
- posted_at: `2026-11-09T23:32:00.5708380+00:00`

## Data

```json
{
  "end_line": 105,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 101,
  "symbol": "TupleLookupMixin.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":101,"selector":"L101-L105","symbol":"TupleLookupMixin.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 105,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 101,
    "symbol": "TupleLookupMixin.process_lhs"
  },
  "id": "aa0b7165-1a48-4a34-8fae-bb5d3632e133",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5708380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 101,
        "selector": "L101-L105",
        "symbol": "TupleLookupMixin.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a3758572-3874-46f4-a2e4-7571086c896c",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection, lhs=None)"
}
```
