# Fact 16e22f14

Store id: eaca3bf6-05e4-4e13-b485-fc072e96ccf1

## Text

```text
class RelatedGreaterThanOrEqual(RelatedLookupMixin, GreaterThanOrEqual)
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
- posted_at: `2026-11-09T22:39:45.1325570+00:00`

## Data

```json
{
  "end_line": 144,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 143,
  "symbol": "RelatedGreaterThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":143,"selector":"L143-L144","symbol":"RelatedGreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedGreaterThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 144,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 143,
    "symbol": "RelatedGreaterThanOrEqual"
  },
  "id": "eaca3bf6-05e4-4e13-b485-fc072e96ccf1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1325570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 143,
        "selector": "L143-L144",
        "symbol": "RelatedGreaterThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "7f618e17-abf7-4568-b4d6-73202963dc7b",
  "subject_name": "django/db/models/fields/related_lookups::RelatedGreaterThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedGreaterThanOrEqual(RelatedLookupMixin, GreaterThanOrEqual)"
}
```
