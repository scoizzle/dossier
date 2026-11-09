# Fact 49956cad

Store id: 3cf05f8f-5b73-44b3-a185-aecfe247f6bf

## Text

```text
contains function _traverse_ancestors
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.0283500+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/related_descriptors::_traverse_ancestors](../../django-db-models-fields-related-descriptors-traverse-ancestors/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":120,"symbol":"_traverse_ancestors"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3cf05f8f-5b73-44b3-a185-aecfe247f6bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.0283500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 120,
        "symbol": "_traverse_ancestors"
      },
      "rel": "contains",
      "target": "178e2b53-4a15-4720-b47c-334134b2a3cc"
    }
  ],
  "status": "live",
  "subject_id": "266dc5c5-9f24-462d-becd-263287321fdc",
  "subject_name": "django/db/models/fields/related_descriptors",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _traverse_ancestors"
}
```
