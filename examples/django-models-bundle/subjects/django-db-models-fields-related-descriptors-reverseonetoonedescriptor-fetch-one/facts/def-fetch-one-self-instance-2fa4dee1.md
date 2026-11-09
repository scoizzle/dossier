# Fact 2fa4dee1

Store id: 9e7d762f-f2ad-4ef7-a10b-b4dd88edf5dd

## Text

```text
def fetch_one(self, instance)
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
- posted_at: `2026-11-09T23:44:51.8802650+00:00`

## Data

```json
{
  "end_line": 569,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 559,
  "symbol": "ReverseOneToOneDescriptor.fetch_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":559,"selector":"L559-L569","symbol":"ReverseOneToOneDescriptor.fetch_one"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.fetch_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 569,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 559,
    "symbol": "ReverseOneToOneDescriptor.fetch_one"
  },
  "id": "9e7d762f-f2ad-4ef7-a10b-b4dd88edf5dd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8802650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 559,
        "selector": "L559-L569",
        "symbol": "ReverseOneToOneDescriptor.fetch_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "46e119d0-9649-43b4-9be6-4914ee79e443",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.fetch_one",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_one(self, instance)"
}
```
