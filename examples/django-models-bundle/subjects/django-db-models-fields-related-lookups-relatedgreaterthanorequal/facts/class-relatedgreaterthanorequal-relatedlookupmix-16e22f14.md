# Fact 16e22f14

Store id: a0f46d03-cc5b-4f13-863e-d685f9785d18

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
- posted_at: `2026-11-09T23:44:52.2847840+00:00`

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
  "id": "a0f46d03-cc5b-4f13-863e-d685f9785d18",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2847840+00:00"
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
  "subject_id": "9a26be30-96e0-44cf-9358-c366413530b5",
  "subject_name": "django/db/models/fields/related_lookups::RelatedGreaterThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedGreaterThanOrEqual(RelatedLookupMixin, GreaterThanOrEqual)"
}
```
