# Fact 0254c816

Store id: c2bd57cd-bea0-4a75-9914-e3d749ab135e

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
- posted_at: `2026-11-09T22:39:45.5827680+00:00`

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
  "id": "c2bd57cd-bea0-4a75-9914-e3d749ab135e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5827680+00:00"
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
  "subject_id": "319a228a-6f76-4ccd-b236-be7909594249",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection, lhs=None)"
}
```
