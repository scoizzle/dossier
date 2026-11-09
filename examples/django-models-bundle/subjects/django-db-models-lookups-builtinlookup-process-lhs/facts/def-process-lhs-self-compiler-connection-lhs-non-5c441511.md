# Fact 5c441511

Store id: e8764fba-7aa9-4465-9a8c-ec277a2e4260

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
- posted_at: `2026-11-09T23:32:03.2121110+00:00`

## Data

```json
{
  "end_line": 241,
  "entity_kind": "method",
  "parent": "BuiltinLookup",
  "start_line": 235,
  "symbol": "BuiltinLookup.process_lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":235,"selector":"L235-L241","symbol":"BuiltinLookup.process_lhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::BuiltinLookup.process_lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 241,
    "entity_kind": "method",
    "parent": "BuiltinLookup",
    "start_line": 235,
    "symbol": "BuiltinLookup.process_lhs"
  },
  "id": "e8764fba-7aa9-4465-9a8c-ec277a2e4260",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2121110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 235,
        "selector": "L235-L241",
        "symbol": "BuiltinLookup.process_lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f8e95652-8195-4a94-9ffd-920dcd13af47",
  "subject_name": "django/db/models/lookups::BuiltinLookup.process_lhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_lhs(self, compiler, connection, lhs=None)"
}
```
