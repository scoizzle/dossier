# Fact dbd74275

Store id: b43fbf3a-7f52-424b-91fe-0e803fc00744

## Text

```text
def output_field(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.8930300+00:00`

## Data

```json
{
  "end_line": 170,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 168,
  "symbol": "Lookup.output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"selector":"L168-L170","symbol":"Lookup.output_field"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 170,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 168,
    "symbol": "Lookup.output_field"
  },
  "id": "b43fbf3a-7f52-424b-91fe-0e803fc00744",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8930300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 168,
        "selector": "L168-L170",
        "symbol": "Lookup.output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c063827b-9ba9-41b9-9201-6b639e0623d1",
  "subject_name": "django/db/models/lookups::Lookup.output_field",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def output_field(self)"
}
```
