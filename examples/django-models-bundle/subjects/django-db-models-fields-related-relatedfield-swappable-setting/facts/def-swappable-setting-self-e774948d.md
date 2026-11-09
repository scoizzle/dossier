# Fact e774948d

Store id: 6ead0d45-631b-46ca-af07-db41945b8f78

## Text

```text
def swappable_setting(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.6309000+00:00`

## Data

```json
{
  "end_line": 465,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 452,
  "symbol": "RelatedField.swappable_setting"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":452,"selector":"L452-L465","symbol":"RelatedField.swappable_setting"}`

## Items

```json
[
  {
    "text": "Get the setting that this is powered from for swapping, or None if it's not swapped in / marked with swappable=False.",
    "locator": {
      "line": 454
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.swappable_setting](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 465,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 452,
    "symbol": "RelatedField.swappable_setting"
  },
  "id": "6ead0d45-631b-46ca-af07-db41945b8f78",
  "items": [
    {
      "locator": {
        "line": 454
      },
      "text": "Get the setting that this is powered from for swapping, or None if it's not swapped in / marked with swappable=False."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6309000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 452,
        "selector": "L452-L465",
        "symbol": "RelatedField.swappable_setting"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "da837757-0f11-4105-bf0f-6e67e7d5a691",
  "subject_name": "django/db/models/fields/related::RelatedField.swappable_setting",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def swappable_setting(self)"
}
```
