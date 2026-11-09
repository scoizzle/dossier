# Fact 9b7f2080

Store id: 7726e146-5176-4bf9-8b94-52d302a4e2af

## Text

```text
def __set__(self, instance, value)
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
- posted_at: `2026-11-09T23:44:51.8842420+00:00`

## Data

```json
{
  "end_line": 650,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 579,
  "symbol": "ReverseOneToOneDescriptor.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":579,"selector":"L579-L650","symbol":"ReverseOneToOneDescriptor.__set__"}`

## Items

```json
[
  {
    "text": "Set the related instance through the reverse relation.",
    "locator": {
      "line": 580
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 650,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 579,
    "symbol": "ReverseOneToOneDescriptor.__set__"
  },
  "id": "7726e146-5176-4bf9-8b94-52d302a4e2af",
  "items": [
    {
      "locator": {
        "line": 580
      },
      "text": "Set the related instance through the reverse relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8842420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 579,
        "selector": "L579-L650",
        "symbol": "ReverseOneToOneDescriptor.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "ad698e2d-c0e3-4666-8527-de53e94af761",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
