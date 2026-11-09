# Fact 243c6e92

Store id: 24b34b1b-978d-4945-94cc-77dca0b6b8b2

## Text

```text
class RelatedIn(In)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.2393240+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 42,
  "symbol": "RelatedIn"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"selector":"L42-L95","symbol":"RelatedIn"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedIn](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 42,
    "symbol": "RelatedIn"
  },
  "id": "24b34b1b-978d-4945-94cc-77dca0b6b8b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2393240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 42,
        "selector": "L42-L95",
        "symbol": "RelatedIn"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "83b5cb13-1043-48a5-8689-59aaef9f37d6",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIn",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedIn(In)"
}
```
